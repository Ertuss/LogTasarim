using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LogToplayıcı.Veritabani_Katmani
{
    public class Veritabani : IDisposable
    {
        MongoClient cli;
        public IMongoDatabase db;
        public Veritabani(string server, int port, string database, string username, string pwd)
        {
            var settings = new MongoClientSettings
            {
                Credential = MongoCredential.CreateCredential(database, username, pwd),
                Server = new MongoServerAddress(server, port),
                ConnectTimeout = TimeSpan.FromMinutes(15),
                SocketTimeout = TimeSpan.FromMinutes(15)
            };

            cli = new MongoClient(settings);
            db = cli.GetDatabase(database);
            
        }
        public bool isConnectionAlive()
        {
            try
            {
                bool isMongoLive = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

                if (isMongoLive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ObjectId GetNewID()
        {
            return ObjectId.GenerateNewId();
        }
        public List<T> Select<T>(string CollectionName, FilterDefinition<T> filter, ProjectionDefinition<T> fields)
        {
            var tbl = db.GetCollection<T>(CollectionName);

            if (filter != null)
            {
                if (fields != null)
                {
                    return tbl.Find<T>(filter).Project<T>(fields).ToList();
                }

                return tbl.Find<T>(filter).ToList();
            }
            if (fields != null)
            {
                return tbl.Find<T>(new BsonDocument()).Project<T>(fields).ToList();
            }
            return tbl.Find<T>(new BsonDocument()).ToList();
        }
        public T SelectOne<T>(string CollectionName, FilterDefinition<T> filter, ProjectionDefinition<T> fields)
        {
            var tbl = db.GetCollection<T>(CollectionName);

            if (filter != null)
            {
                if (fields != null)
                {
                    return tbl.Find<T>(filter).Project<T>(fields).FirstOrDefault();
                }

                return tbl.Find<T>(filter).FirstOrDefault();
            }
            if (fields != null)
            {
                return tbl.Find<T>(new BsonDocument()).Project<T>(fields).FirstOrDefault();
            }
            return tbl.Find<T>(new BsonDocument()).FirstOrDefault();
        }
        public List<T> SelectWithJoin<T>(string CollectionName, FilterDefinition<T> filter, string ForeignCollection, string LocalField, string ForeignField, string AsName, int limit, int page)
        {
            var tbl = db.GetCollection<T>(CollectionName);

            if (filter != null)
            {
                return tbl.Aggregate<T>().Match(filter).Lookup<T>(ForeignCollection, LocalField, ForeignField, AsName).Skip(limit * page).Limit(limit).As<T>().ToList<T>();
            }
            else
            {
                return tbl.Aggregate<T>().Lookup<T>(ForeignCollection, LocalField, ForeignField, AsName).Skip(limit * page).Limit(limit).As<T>().ToList<T>();
            }
        }
        public List<BsonDocument> SelectBsonDocument(string CollectionName, FieldDefinition<BsonDocument> field, FilterDefinition<BsonDocument> filter, string _Group, SortDefinition<BsonDocument> sort, int limit)
        {
            var tbl = db.GetCollection<BsonDocument>(CollectionName);

            if (filter != null)
            {
                if (field == null)
                {
                    if (sort == null)
                    {
                        return tbl.Aggregate(new AggregateOptions() { AllowDiskUse = true, UseCursor = null }).Match(filter).Group(_Group).Limit(limit).ToList<BsonDocument>();
                    }
                    return tbl.Aggregate(new AggregateOptions() { AllowDiskUse = true, UseCursor = null }).Match(filter).Group<BsonDocument>(_Group).Sort(sort).Limit(limit).ToList();
                }
                return tbl.Aggregate(new AggregateOptions() { AllowDiskUse = true, UseCursor = null }).Unwind(field).Match(filter).Group<BsonDocument>(_Group).Sort(sort).Limit(limit).ToList();
            }
            else
            {
                if (field == null)
                {
                    return tbl.Aggregate(new AggregateOptions() { AllowDiskUse = true, UseCursor = null }).Group<BsonDocument>(_Group).Sort(sort).Limit(limit).ToList();
                }
                else
                {
                    return tbl.Aggregate(new AggregateOptions() { AllowDiskUse = true, UseCursor = null }).Unwind(field).Group<BsonDocument>(_Group).Sort(sort).Limit(limit).ToList();
                }

                return tbl.Aggregate(new AggregateOptions() { AllowDiskUse = true, UseCursor = null }).Unwind(field).Group<BsonDocument>(_Group).Sort(sort).Limit(limit).ToList();
            }
        }
        public bool Insert<T>(string CollectionName, object values)
        {
            try
            {
                var tbl = db.GetCollection<T>(CollectionName);
                try
                {
                    tbl.InsertMany((List<T>)values);
                }
                catch
                {
                    tbl.InsertOne((T)values);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool InsertOne<T>(string CollectionName, object values)
        {
            try
            {
                var tbl = db.GetCollection<T>(CollectionName);

                tbl.InsertOne((T)values);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public UpdateResult Update<T>(string CollectionName, UpdateDefinition<T> values, FilterDefinition<T> filter)
        {
            UpdateResult updateResult = null;
            try
            {
                var tbl = db.GetCollection<T>(CollectionName);

                updateResult = tbl.UpdateOne(filter, values, new UpdateOptions() { IsUpsert = true });
            }
            catch (Exception ex)
            {
                return updateResult;
            }

            return updateResult;
        }

        public DeleteResult Delete<T>(string CollectionName, FilterDefinition<T> filter)
        {
            DeleteResult updateResult = null;
            try
            {
                var tbl = db.GetCollection<T>(CollectionName);

                updateResult = tbl.DeleteOne(filter);
            }
            catch (Exception ex)
            {
                // ex.WriteException();
                return updateResult;
            }

            return updateResult;
        }

        public UpdateResult UpdateMany<T>(string CollectionName, UpdateDefinition<T> values, FilterDefinition<T> filter)
        {
            UpdateResult updateResult = null;
            try
            {
                var tbl = db.GetCollection<T>(CollectionName);

                updateResult = tbl.UpdateMany(filter, values, new UpdateOptions() { IsUpsert = true });
            }
            catch (Exception ex)
            {
                //ex.WriteException();
                return updateResult;
            }

            return updateResult;
        }
        private bool IsDisposed = false;
        public void Free()
        {
            if (IsDisposed)
            {
                throw new ObjectDisposedException("Object Name");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Veritabani()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposedStatus)
        {
            if (!IsDisposed)
            {
                IsDisposed = true;
                if (disposedStatus)
                {
                }
            }
        }




    }
}

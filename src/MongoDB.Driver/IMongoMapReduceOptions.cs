﻿/* Copyright 2010-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;

namespace MongoDB.Driver
{
    /// <summary>
    /// A marker interface that represents options for a map/reduce operation (see MapReduceOptionsDocument and the MapReduceOptions builder).
    /// </summary>
    [Obsolete("Use MapReduceArgs instead.")]
    [BsonSerializer(typeof(UndiscriminatedActualTypeSerializer<IMongoMapReduceOptions>))]
    public interface IMongoMapReduceOptions
    {
    }
}
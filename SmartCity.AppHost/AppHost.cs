var builder = DistributedApplication.CreateBuilder(args);

// ============================================
// INFRASTRUCTURE LAYER (Docker Containers)
// ============================================

// 1. PostgreSQL - Persistent storage for intersection states
var postgres = builder.AddPostgres("postgres-server")
    .WithPgAdmin()                    // Adds a web UI to inspect the DB
    .AddDatabase("TrafficDb");        // Creates a logical database

// 2. Redis - High-speed state cache (TTL locks, rate limiting)
var redis = builder.AddRedis("cache")
    .WithRedisCommander();            // Adds a web UI to inspect Redis keys

// 3. RabbitMQ - Command & Control message broker
var rabbitmq = builder.AddRabbitMQ("messaging")
    .WithManagementPlugin();          // Adds the RabbitMQ Management UI (port 15672)

// 4. Kafka - High-throughput telemetry stream broker
var kafka = builder.AddKafka("streaming")
    .WithKafkaUI();                   // Adds a web UI to inspect topics and messages

// ============================================
// APPLICATION LAYER (Microservices)
// Will be added on Day 4 after creating projects
// ============================================

builder.Build().Run();
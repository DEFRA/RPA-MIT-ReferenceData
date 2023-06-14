#!/bin/bash
echo "db update on $POSTGRES_HOST $SCHEMA_NAME as $SCHEMA_USERNAME"
/scripts/postgres-wait && /liquibase/liquibase \
--driver=org.postgresql.Driver \
--changeLogFile=/changelog/db.changelog.xml \
--url=jdbc:postgresql://$POSTGRES_HOST:$POSTGRES_PORT/$POSTGRES_DB \
--username="$SCHEMA_USERNAME" --password="$SCHEMA_PASSWORD" --defaultSchemaName="$SCHEMA_NAME" \
rollback v0.0.0


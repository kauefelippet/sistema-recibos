FROM mysql:8.0.39

ENV MYSQL_DATABASE=recibos_db
ENV MYSQL_ROOT_PASSWORD=secret

EXPOSE 3307

COPY ./init.sql /docker-entrypoint-initdb.d/

CMD ["mysqld"]

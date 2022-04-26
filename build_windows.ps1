$env:GIT_COMMIT=git log -1 --format=%h;
$env:BUILD_TIME=get-date -format "yy-MM-dd-HH:mm:ss";
docker-compose build --build-arg GIT_COMMIT=$env:GIT_COMMIT --build-arg BUILD_TIME=$env:BUILD_TIME moviecatalog.api;

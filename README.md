# .NET Sample Applications

This repo has sample .NET 8 and 9 applications to be used for comparison on the behavior with Linkerd.

## Build Applications

### Build .NET 8 Application

```bash
cd Net8PacketTest/
```

```bash
docker build -t <your_image_repo>/dotnet-8-app:v1 .
```

Push to your repo

```bash
docker push <your_image_repo>/dotnet-8-app:v1
```

### Build .NET 9 Application

```bash
cd Net9PacketTest/
```

```bash
docker build -t <your_image_repo>/dotnet-9-app:v1 .
```

Push to your repo

```bash
docker push <your_image_repo>/dotnet-9-app:v1
```

## Deploy Applications

You can find sample manifest in `k8s-manifest/`. 

If you want to use the Locust Load Tester you will need to build that image first.

### Deploy Sample manifest

Update the manifest in `k8s-manifest` with the image location for the sample applications.

Once updated, apply the manifest:

```bash
kubectl apply -f k8s-manifest/dotnet-8-sample-deploy.yaml,k8s-manifest/dotnet-9-sample-deploy.yaml
```

## Run Load Test Applications

Generate load on the sample applications. 

If you want to use Locust, you will need to build the image and push it to your image repo.

### Build Locust Image

Navigate to the [`k8s-locust-load-tester`](k8s-locust-load-tester/README.md)

### Deploy Load test

Update the manifest in `k8s-manifest` with the image location for the locust load tester container you built and pushed to your image repo.

Once updated, apply the manifest:

```bash
kubectl apply -f k8s-manifest/locust-load-test.yaml
```

# .NET AOP (Aspect Oriented Programming)

Bu proje, .NET ile Aspect Oriented Programming (AOP) yaklaşımını kullanarak nasıl loglama yapılacağını göstermektedir. Bu örnekte [AspectInjector](https://github.com/pamidur/aspect-injector) kütüphanesi kullanılmıştır.

## Kullanım

1. Projeyi açın:
```sh
cd DotNetAOP_Tutorial
```

2. Gerekli NuGet paketini yükleyin:
```sh
dotnet add package AspectInjector
```

3. Projeyi çalıştırın:
```sh
dotnet run
```

## Açıklama

`LogAspect` adında bir aspect sınıfı oluşturduk ve bu sınıfı `Log` attribute'u ile işaretlediğimiz metodun başında ve sonunda otomatik loglama yapacak şekilde ayarladık.

## Dosyalar

- `Program.cs` - Örnek kullanım
- `LogAspect.cs` - Aspect sınıfı

## Gereksinimler

- .NET 7 SDK+

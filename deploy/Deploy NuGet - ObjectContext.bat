CALL ../../set-nuget-key.bat

del *.nupkg

nuget pack ObjectContext\Ministry.EntityFrameworkRepositoryBuilder.ObjectContext.Ef4.nuspec
nuget pack ObjectContext\Ministry.EntityFrameworkRepositoryBuilder.ObjectContext.Ef5.nuspec
nuget pack ObjectContext-EF6\Ministry.EntityFrameworkRepositoryBuilder.ObjectContext.Ef6.nuspec

nuget push *.nupkg

pause
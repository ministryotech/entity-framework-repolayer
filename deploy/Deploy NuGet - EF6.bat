CALL ../../set-nuget-key.bat

del *.nupkg

nuget pack ObjectContext-EF6\Ministry.EntityFrameworkRepositoryBuilder.ObjectContext.Ef6.nuspec
nuget pack DbContext\Ministry.EntityFrameworkRepositoryBuilder.DbContext.Ef6.nuspec

nuget push *.nupkg

pause
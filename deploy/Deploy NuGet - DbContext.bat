CALL ../../set-nuget-key.bat

del *.nupkg

nuget pack DbContext\Ministry.EntityFrameworkRepositoryBuilder.DbContext.Ef5.nuspec
nuget pack DbContext\Ministry.EntityFrameworkRepositoryBuilder.DbContext.Ef6.nuspec

nuget push *.nupkg

pause
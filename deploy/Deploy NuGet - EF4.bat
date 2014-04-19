CALL ../../set-nuget-key.bat

del *.nupkg

nuget pack ObjectContext\Ministry.EntityFrameworkRepositoryBuilder.ObjectContext.Ef4.nuspec

nuget push *.nupkg

pause
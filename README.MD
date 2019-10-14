```
Add-Migration -Name {{NameOfMigration}} -StartupProject EFBugGithubSample
```

throws the following error:

> Add-Migration -Name AddedPointProperties -StartupProject EFBugGithubSample
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 3.0.0 initialized 'DataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: MigrationsAssembly=EFBugGithubSample.DataAccess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null using lazy-loading proxies 
System.NullReferenceException: Object reference not set to an instance of an object.
   at lambda_method(Closure , ValueBuffer )
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.InternalShadowEntityEntry..ctor(IStateManager stateManager, IEntityType entityType, ValueBuffer& valueBuffer)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.InternalEntityEntryFactory.NewInternalEntityEntry(IStateManager stateManager, IEntityType entityType, Object entity, ValueBuffer& valueBuffer)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.InternalEntityEntryFactory.Create(IStateManager stateManager, IEntityType entityType, Object entity, ValueBuffer& valueBuffer)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.CreateEntry(IDictionary`2 values, IEntityType entityType)
   at Microsoft.EntityFrameworkCore.Update.Internal.UpdateAdapter.CreateEntry(IDictionary`2 values, IEntityType entityType)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationsModelDiffer.TrackData(IModel source, IModel target)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationsModelDiffer.Diff(IModel source, IModel target, DiffContext diffContext)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationsModelDiffer.GetDifferences(IModel source, IModel target)
   at Microsoft.EntityFrameworkCore.Migrations.Design.MigrationsScaffolder.ScaffoldMigration(String migrationName, String rootNamespace, String subNamespace, String language)
   at Microsoft.EntityFrameworkCore.Design.Internal.MigrationsOperations.AddMigration(String name, String outputDir, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.AddMigrationImpl(String name, String outputDir, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.AddMigration.<>c__DisplayClass0_0.<.ctor>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.<>c__DisplayClass3_0`1.<Execute>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.Execute(Action action)
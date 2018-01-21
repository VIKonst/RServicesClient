using System;

namespace DataAnalyzer.DbStorage
{
	class Scripts
	{
		public const String CREATE_TABLES =

		@"           
drop table if exists __DaytaAnalyseScripts;

drop table if exists __DaytaAnalyseCategories;

create table __DaytaAnalyseScripts
(
	ID int identity(1,1) Primary key,
	Name nvarchar(100),
	Script nvarchar(max),
	SqlInput nvarchar(max),
	CategoryId int,
);

create table __DaytaAnalyseCategories
(
	ID int identity(1,1) Primary key,
	Name nvarchar(100),
	ParentId int,
);        
		";




		public const String SELECT_STRUCTURE =
		@"
select t.name + ' ' +c.name as columnData
from sys.tables t
join sys.all_columns c on c.object_id = t.object_id
where t.name in ('__DaytaAnalyseScripts', '__DaytaAnalyseCategories')

		";

		public const String SELECT_TOP_CATEGORIES =
	   @"
select ID as ID, Name
FROM __DaytaAnalyseCategories WHERE ParentId = 0;
		";

		public const String SELECT_CATEGORIES_BY_PARENT =
		@"
select ID as ID, Name
FROM __DaytaAnalyseCategories WHERE ParentId  = @parentId;
		";



		public const String INSTER_CATEGORY =
		@"
insert into __DaytaAnalyseCategories(Name, ParentId)
VALUES(@name, @parentId)
		";

		public const String SELECT_SCRIPTS =
		@"
SELECT ID, Name, Script, SqlInput, CategoryId FROM __DaytaAnalyseScripts WHERE  CategoryId = @categoryId
		";

		public const String INSTER_SCRIPT   = @"
insert into __DaytaAnalyseScripts(Name, CategoryId, Script, SqlInput)
VALUES(@name, @categoryId, N'', N'')
		";

		public const String UPDATE_SCRIPT =
		@"
			UPDATE __DaytaAnalyseScripts SET 

			Name = @Name,
			Script = @Script,
			SqlInput = @SqlInput

			WHERE ID = @ID        
		";
	}
}

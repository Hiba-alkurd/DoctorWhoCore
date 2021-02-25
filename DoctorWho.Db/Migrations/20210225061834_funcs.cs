using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class funcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var func_companions = @"CREATE FUNCTION fnCompanions ( @EpisodeId int)
                                RETURNS TABLE 
                                AS
                                RETURN (

                                SELECT [CompanionName]
	                            FROM [dbo].[Companions] c
	                            INNER JOIN [dbo].[EpisodeCompanions] e ON c.CompanionId = e.CompanionId AND e.EpisodeID = @EpisodeId
	                            )";
            migrationBuilder.Sql(func_companions);

            var func_enemies = @"CREATE FUNCTION fnEnemies ( @EpisodeId int)
                                RETURNS TABLE 
                                AS
                                RETURN (

                                SELECT [EnemyName]
	                            FROM [dbo].[Enemies] c
	                            INNER JOIN [dbo].[EpisodeEnemies] e ON c.EnemyId = e.EnemyId AND e.EpisodeID = @EpisodeId
	                            )";
            migrationBuilder.Sql(func_enemies);

            var proc = @"DROP PROCEDURE IF EXISTS spSummariseEpisodes;
                        GO
                        CREATE PROCEDURE spSummariseEpisodes 
                        AS BEGIN
	                        SELECT TOP(3) c.CompanionId ,  e.CompanionName
	                        FROM [dbo].[EpisodeCompanions] c
		                        INNER JOIN [dbo].[Companions] e ON c.CompanionId = e.CompanionId
	                        GROUP BY c.CompanionId, e.CompanionName
	                        ORDER BY Count(*) DESC

	                        SELECT TOP(3) c.EnemyId, e.EnemyName
	                        FROM [dbo].[EpisodeEnemies] c
		                        INNER JOIN [dbo].[Enemies] e ON c.EnemyId = e.EnemyId
	                        GROUP BY c.EnemyId , e.EnemyName
	                        ORDER BY Count(*) DESC

                        END;";
            migrationBuilder.Sql(proc);

            var view = @"CREATE VIEW viewEpisodes AS
                        SELECT EpisodeId, Title, AuthorName, DoctorName, CompanionName, EnemyName
                        FROM [dbo].[Episodes] e
                        Left Join [dbo].[Authors] a on a.AuthorId = e.AuthorId
                        Left Join [dbo].[Doctors] d on d.DoctorId = e.DoctorId
                        Cross apply [dbo].[fnCompanions](e.EpisodeId) 
                        Cross apply [dbo].[fnEnemies](e.EpisodeId)
                       ";
            migrationBuilder.Sql(view);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

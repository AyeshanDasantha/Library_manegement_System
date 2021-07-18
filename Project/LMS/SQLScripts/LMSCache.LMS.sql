IF NOT EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'LMS')) 
   ALTER DATABASE [LMS] 
   SET  CHANGE_TRACKING = ON
GO

create database SLOT5
ON PRIMARY ( name = slot5, filename = 'D:\Coding Project\SQLStudy\Slot5.mdf', size = 10mb, maxsize = 20mb, filegrowth = 2mb )
log on ( name = slot5log, filename = 'D:\Coding Project\SQLStudy\Slot5_log.mdf', size = 5mb, maxsize = 7mb, filegrowth = 1mb )


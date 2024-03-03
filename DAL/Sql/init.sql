-- TotalChatsReport Data Insertion
INSERT INTO total_chats_reports (date, total_chats) VALUES
('2024-01-01', 760), ('2024-01-02', 819), ('2024-01-03', 815), ('2024-01-04', 806), 
('2024-01-05', 721), ('2024-01-06', 735), ('2024-01-07', 742), ('2024-01-08', 839),
('2024-01-09', 766), ('2024-01-10', 752), ('2024-01-11', 807), ('2024-01-12', 866),
('2024-01-13', 895), ('2024-01-14', 76);

-- DurationReports Data Insertion
-- Assuming a table structure with: id, date, agents_chatting_duration, count, total_duration
INSERT INTO duration_reports (date, agents_chatting_duration, count, total_duration) VALUES
('2024-01-01', 407, 760, 590), ('2024-01-02', 394, 819, 560), ('2024-01-03', 396, 815, 556),
('2024-01-04', 444, 806, 593), ('2024-01-05', 420, 721, 565), ('2024-01-06', 381, 735, 531),
('2024-01-07', 385, 742, 556), ('2024-01-08', 461, 839, 633), ('2024-01-09', 470, 766, 629),
('2024-01-10', 385, 752, 532), ('2024-01-11', 438, 807, 591), ('2024-01-12', 388, 866, 528),
('2024-01-13', 456, 895, 612), ('2024-01-14', 410, 76, 535);

-- RatingsReports Data Insertion
INSERT INTO ratings_reports (date, good, bad) VALUES
('2024-01-01', 78, 19), ('2024-01-02', 78, 19), ('2024-01-03', 68, 28), ('2024-01-04', 88, 25),
('2024-01-05', 81, 16), ('2024-01-06', 72, 12), ('2024-01-07', 81, 16), ('2024-01-08', 97, 21),
('2024-01-09', 54, 26), ('2024-01-10', 56, 26), ('2024-01-11', 73, 24), ('2024-01-12', 90, 26),
('2024-01-13', 71, 21), ('2024-01-14', 11, 0);

-- ResponseTimeReports Data Insertion
INSERT INTO response_time_reports (date, count, response_time) VALUES
('2024-01-01', 583, 51.06), ('2024-01-02', 637, 47.69), ('2024-01-03', 624, 47.55),
('2024-01-04', 626, 47.53), ('2024-01-05', 555, 48.09), ('2024-01-06', 558, 44.11),
('2024-01-07', 552, 44.55), ('2024-01-08', 677, 53.39), ('2024-01-09', 588, 53.29),
('2024-01-10', 582, 45.97), ('2024-01-11', 633, 48.63), ('2024-01-12', 618, 47.21),
('2024-01-13', 662, 56), ('2024-01-14', 54, 48.41);

-- TagsReports & Tags Data Insertion
-- Assuming a process to insert TagsReport first, then Tags with a reference to TagsReportId
-- Example for one TagsReport and its Tags, repeat for each report and adjust TagsReportId accordingly
INSERT INTO tags_reports (date, name) VALUES ('2024-01-01', 'tags-report');
-- Assuming TagsReportId = 1 for the first insert, replace with actual IDs obtained
INSERT INTO tags (name, count, tags_report_id) VALUES
('Adam', 13, 1), ('Alex', 26, 1), ('Chernozub.l', 15, 1), ('Close - in progress', 18, 1);
-- Repeat INSERT INTO tags for each date and its tags

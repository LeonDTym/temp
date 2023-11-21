# temp
https://www.dotnetxp.com/download-csv-file-asp-net-mvc/
CREATE PROCEDURE getStudents()
BEGIN
    SELECT
        s.kid_name,
        s.kid_surname,
        s.year_birthday
    FROM Students s
    WHERE EXISTS (
        SELECT
            1
        FROM Students s2
        WHERE s.kid_name = s2.kid_name AND
            s.kid_surname = s2.kid_surname AND
            s.year_birthday = s2.year_birthday AND
            s.student_id <> s2.student_id
    )
    ORDER BY s.kid_surname, s.kid_name, s.year_birthday;
END

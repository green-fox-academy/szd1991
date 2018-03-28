-- Exercises @ https://lagunita.stanford.edu/courses/DB/SQL/SelfPaced/courseware/ch-sql/seq-exercise-sql_movie_query_extra/

-- Q1

	SELECT name FROM Movie
	LEFT JOIN Rating USING(mID)
	LEFT JOIN Reviewer USING(rID)
	WHERE title = "Gone with the Wind"
	GROUP BY name;
	
-- Q2

	SELECT name, title, stars
	FROM Movie
	LEFT JOIN Rating USING(mID)
	LEFT JOIN Reviewer USING(rID)
	WHERE name = director;
	
-- Q3

	SELECT name FROM Reviewer
	UNION
	SELECT title FROM Movie;
	
-- Q4


-- Q5


-- Q6


-- Q7


-- Q8


-- Q9


-- Q10


-- Q11


-- Q12


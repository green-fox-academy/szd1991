-- Exercises @ https://lagunita.stanford.edu/courses/DB/SQL/SelfPaced/courseware/ch-sql/seq-exercise-sql_movie_query_core/

-- Q1

	SELECT title FROM Movie
	WHERE director LIKE "Steven Spielberg";

-- Q2

	SELECT DISTINCT Year FROM Movie
	LEFT JOIN Rating
	ON Movie.mID = Rating.mID
	WHERE stars >= 4;

-- Q3

	SELECT DISTINCT title
	FROM Movie
	LEFT JOIN Rating
	ON Movie.mID = Rating.mID
	WHERE stars IS NULL

-- Q4

	SELECT DISTINCT name FROM Reviewer
	LEFT JOIN Rating
	ON Reviewer.rID = Rating.rID
	WHERE ratingDate IS NULL;

-- Q5

	SELECT name, title, stars, ratingDate
	FROM Movie
	LEFT JOIN Rating ON Movie.mID = Rating.mID
	LEFT JOIN Reviewer ON Rating.rID = Reviewer.rID
	WHERE title IS NOT NULL
	AND stars IS NOT NULL
	ORDER BY name ASC,
	title ASC,
	stars ASC;

-- Q6

	SELECT name, title FROM Movie
	LEFT JOIN Rating ROne USING(mID)
	LEFT JOIN Rating RTwo USING(rID)
	LEFT JOIN Reviewer USING(rID)
	WHERE ROne.mID = RTwo.mID
	AND ROne.ratingDate < RTwo.ratingDate
	AND RTwo.stars > ROne.stars;

-- Q7

	SELECT title, MAX(stars) FROM Movie
	LEFT JOIN Rating ON Movie.mID = Rating.mID
	WHERE stars IS NOT NULL
	GROUP BY title
	ORDER BY title ASC;

-- Q8

	SELECT title, MAX(stars) - MIN(stars) AS rating_spread
	FROM Movie
	LEFT JOIN Rating ON Movie.mID = Rating.mID
	WHERE stars IS NOT NULL
	GROUP BY title
	ORDER BY rating_spread DESC,
	title ASC;

-- Q9


import "./App.css";

import BookDetails from "./BookDetails";
import BlogDetails from "./BlogDetails";
import CourseDetails from "./CourseDetails";

import {
    books,
    blogs,
    courses
} from "./Data";

function App() {

    const showBooks = true;
    const showBlogs = true;
    const showCourses = true;

    return (

        <div className="container">

            <div className="section">

                <h1>Course Details</h1>

                {
                    showCourses &&
                    <CourseDetails courses={courses} />
                }

            </div>

            <div className="section">

                <h1>Book Details</h1>

                {
                    showBooks
                        ? <BookDetails books={books} />
                        : <h3>No Books Available</h3>
                }

            </div>

            <div className="section">

                <h1>Blog Details</h1>

                {
                    showBlogs
                        ? <BlogDetails blogs={blogs} />
                        : <h3>No Blogs Available</h3>
                }

            </div>

        </div>

    );

}

export default App;
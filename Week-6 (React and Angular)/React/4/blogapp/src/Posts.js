import React, { Component } from "react";
import Post from "./Post";

class Posts extends Component {

     constructor(props) {
    super(props);
    this.state = { posts: [] };
  }

  loadPosts = () => {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => {
        if (!response.ok) throw new Error('Network error');
        return response.json();
      })
      .then(data => {
        const posts = data.map(
          post => new Post(post.userId, post.id, post.title, post.body)
        );
        this.setState({ posts });
      })
      .catch(error => { throw error; });
  };

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    alert('An error occurred: ' + error.message);
  }

  render() {
    return (
      <div>
        <h1>Blog Posts</h1>
        {this.state.posts.map(post => (
          <div key={post.id} style={{ marginBottom: "40px" }}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
            <hr/>
          </div>
        ))}
      </div>
    );
  }
}


export default Posts;
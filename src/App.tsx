import React from 'react';
import styles from './App.module.css';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import HomePage from './components/home/HomePage';


const router = createBrowserRouter([
  {
    path: "/",
    element:<HomePage/>
  }
]);
function App() {
  return (
    <>
      <RouterProvider router={router} />
    </>
  );
}

export default App;

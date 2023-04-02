import React from 'react';
import styles from './App.module.css';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import DefaultLayout from './components/containers/DefaultLayout';
import HomePage from './components/containers/home/HomePage';


const router = createBrowserRouter([
  {
    path: "/",
    element:<DefaultLayout/>,
    children:[
      {index:true,element: <HomePage></HomePage>}
    ]
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

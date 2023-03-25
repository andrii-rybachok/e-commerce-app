import React from 'react';
import styles from './App.module.css';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import DefaultLayout from './components/containers/DefaultLayout';


const router = createBrowserRouter([
  {
    path: "/",
    element:<DefaultLayout/>
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

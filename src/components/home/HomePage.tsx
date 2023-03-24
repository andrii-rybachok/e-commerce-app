import { Outlet } from "react-router-dom";


export default function HomePage(){
    return(
        <>  
            <h1>Hello world</h1>
            <Outlet/>
        </>
    );
}
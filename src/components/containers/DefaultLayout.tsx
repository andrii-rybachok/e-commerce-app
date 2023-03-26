import { Outlet } from "react-router-dom";
import DefaultHeader from "./header/DefaultHeader";

import DefaultNavigation from "./navigation/DefaultNavigation";


export default function DefaultLayout(){
    return(
        <>             
            <DefaultHeader/>
            <DefaultNavigation/>
            <main>
               <Outlet/>
            </main>
            
        </>
    );
}
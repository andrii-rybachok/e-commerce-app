import { useState } from "react";

export default function useStars({rating}:{rating:number|any}){
    
    const stars = [];
    let decimal = rating - Math.floor(rating);
    
    for (let index = 0; index < 5; index++) {
        let item;
        if (decimal!=0&&rating - decimal == index) {
          if (0.13 <= decimal && decimal < 0.375) {
            item=
              <svg
                xmlns="http://www.w3.org/2000/svg"
                xmlnsXlink="http://www.w3.org/1999/xlink"
                viewBox="0 0 32 32"
              >
                <defs>
                  <linearGradient id="quaterGrad">
                    <stop offset="25%" stop-color="#EDA415" />
                    <stop offset="75%" stop-color="#ACACAC" />
                  </linearGradient>
                </defs>
                <path
                  fill="url(#quaterGrad)"
                  d="M20.388,10.918L32,12.118l-8.735,7.749L25.914,31.4l-9.893-6.088L6.127,31.4l2.695-11.533L0,12.118
                      l11.547-1.2L16.026,0.6L20.388,10.918z"
                />
              </svg>;
       
          } else if (0.375 <= decimal && decimal < 0.625) {
            item=
              <svg
                xmlns="http://www.w3.org/2000/svg"
                xmlnsXlink="http://www.w3.org/1999/xlink"
                viewBox="0 0 32 32"
              >
                <defs>
                  <linearGradient id="halfGrad">
                    <stop offset="50%" stop-color="#EDA415" />
                    <stop offset="50%" stop-color="#ACACAC" />
                  </linearGradient>
                </defs>
                <path
                  fill="url(#halfGrad)"
                  d="M20.388,10.918L32,12.118l-8.735,7.749L25.914,31.4l-9.893-6.088L6.127,31.4l2.695-11.533L0,12.118
                      l11.547-1.2L16.026,0.6L20.388,10.918z"
                />
              </svg>
            ;
  
          } else if (0.625 <= decimal && decimal <= 0.75) {
            item=
              <svg
                xmlns="http://www.w3.org/2000/svg"
                xmlnsXlink="http://www.w3.org/1999/xlink"
                viewBox="0 0 32 32"
              >
                <defs>
                  <linearGradient id="threeQuatersGrad">
                    <stop offset="75%" stop-color="#EDA415" />
                    <stop offset="25%" stop-color="#ACACAC" />
                  </linearGradient>
                </defs>
                <path
                  fill="url(#threeQuatersGrad)"
                  d="M20.388,10.918L32,12.118l-8.735,7.749L25.914,31.4l-9.893-6.088L6.127,31.4l2.695-11.533L0,12.118
                      l11.547-1.2L16.026,0.6L20.388,10.918z"
                />
              </svg>
            ;
          }
          stars.push(item);
          continue;
        }
        if (rating > index || decimal >= 0.75) {
          item=
            <svg
              xmlns="http://www.w3.org/2000/svg"
              xmlnsXlink="http://www.w3.org/1999/xlink"
              viewBox="0 0 32 32"
            >
              <defs>
                <linearGradient id="fullGrad">
                  <stop offset="100%" stop-color="#EDA415" />
                </linearGradient>
              </defs>
              <path
                fill="url(#fullGrad)"
                d="M20.388,10.918L32,12.118l-8.735,7.749L25.914,31.4l-9.893-6.088L6.127,31.4l2.695-11.533L0,12.118
                      l11.547-1.2L16.026,0.6L20.388,10.918z"
              />
            </svg>
          ;
        }
        else{item = (
          <svg
            xmlns="http://www.w3.org/2000/svg"
            xmlnsXlink="http://www.w3.org/1999/xlink"
            viewBox="0 0 32 32"
          >
            <defs>
              <linearGradient id="grad">
                <stop offset="100%" stop-color="#ACACAC" />
              </linearGradient>
            </defs>
            <path
              fill="url(#grad)"
              d="M20.388,10.918L32,12.118l-8.735,7.749L25.914,31.4l-9.893-6.088L6.127,31.4l2.695-11.533L0,12.118
                      l11.547-1.2L16.026,0.6L20.388,10.918z"
            />
          </svg>
        );
        }
        stars.push(item);
      }
    return stars;
}
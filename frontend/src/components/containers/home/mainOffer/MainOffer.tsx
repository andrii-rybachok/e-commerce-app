
import styles from './MainOffer.module.css';
import { useEffect, useRef, useState } from 'react';
import IProductPreview from '@/types/products/product/IProductPreview';
import axios from 'axios';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid } from '@fortawesome/fontawesome-svg-core/import.macro'
import { useMainOffer } from '../Providers/MainOfferProvider';

export default function MainOffer(){
    const products = useMainOffer();
    const [currentImg, setCurrentImg] = useState<number>(0);
    const elementsToScroll = useRef<Map<any,any>>();
    function handleLeftSlide(){
        if (currentImg==0) {           
            setCurrentImg(products.length-1);
        }
        else if(0<currentImg){
            setCurrentImg(currentImg-1);
        }
        fadeInScrollItems();
        
    }
    function handleRightSlide(){
        if (products.length-1>currentImg) {           
            setCurrentImg(currentImg+1);       
        }
        else if( products.length-1===currentImg){
            setCurrentImg(0);
        }
        fadeInScrollItems();
        
    }
    function getScrollItems() {
        if (!elementsToScroll.current) {
            // Initialize the Map on first usage.
            elementsToScroll.current = new Map();
        }
        return elementsToScroll.current;
    }
    function addToScrollItems(id:number,item:any){
        const items=getScrollItems();
        if(item){
            items.set(id,item);
        }
        else{
            items.delete(item);
        }
    }
    function fadeInScrollItems(){
        const items = getScrollItems();
        items.forEach((item,index)=>{
            item.classList.add("scrolledElement");
            
            setTimeout(()=>{
                item.classList.remove("scrolledElement");
            },400);           
        })
    }
    if(products.length===0) return (<><h1>Loading...</h1></>);
    let imgSrc = "https://localhost:7100/images/big/"+products.at(currentImg)?.previewImage;
    return(
        <>
            <section>
                <div className={styles.miniSlider}>
                    <button className={styles.arrow} style={{marginRight:'50px'}} onClick={handleLeftSlide}><FontAwesomeIcon icon={solid("chevron-left")} /></button>
                    <div className={styles.actionSide}>
                        <h2 ref={(node)=>addToScrollItems(1,node)}>{products.at(currentImg)?.name}</h2>
                        <button className={styles.shopBtn}>Shop now</button>
                        <button className={styles.viewBtn}>View more</button>
                    </div>
                    <div className={styles.imgSide} >
                        <div >
                            <img className={styles.promoImage} ref={(node)=>addToScrollItems(2,node)} src={imgSrc} alt="" />                            
                            <div className={styles.bigYellowCircle}><span ref={(node)=>addToScrollItems(3,node)}>only ${products.at(currentImg)?.price}</span></div>
                        </div>
                    </div>
                    <button className={styles.arrow} style={{marginLeft:'50px'}} onClick={handleRightSlide}><FontAwesomeIcon icon={solid("chevron-right")} /></button>

                </div>
            </section>
        </>
    );
}
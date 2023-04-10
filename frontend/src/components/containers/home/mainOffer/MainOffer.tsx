
import styles from './MainOffer.module.css';
import { useEffect, useRef, useState } from 'react';
import IProductPreview from '@/types/products/product/IProductPreview';
import axios from 'axios';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid } from '@fortawesome/fontawesome-svg-core/import.macro'
import { useMainOffer } from '../providers/MainOfferProvider';
import Indicator from '@/components/indicator/Indicator';
import usePagination from '@/customHooks/usePagination';

export default function MainOffer(){
    const products = useMainOffer();
    const pageSystem = usePagination({maxItemsOnPage:1,
        itemsLength:4});
    
    const elementsToScroll = useRef<Map<any,any>>();

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
    let pagination = pageSystem.pagination;
    let imgSrc = "https://localhost:7100/images/big/"+products.at(pagination.currentPage)?.previewImage;
    return(
        <>
            <section>
                <div className={styles.miniSlider}>
                    
                    <div className={styles.actionSide}>
                        <h2 ref={(node)=>addToScrollItems(1,node)}>{products.at(pagination.currentPage)?.name}</h2>
                        <div>
                            <button className={styles.shopBtn}>Shop now</button>
                            <button className={styles.viewBtn}>View more</button>
                        </div>
                        <div className={styles.indicators}>
                            {pageSystem.indicators}
                        </div>
                    </div>
                    <div className={styles.imgSide} >
                        <div >
                            <img className={styles.promoImage} ref={(node)=>addToScrollItems(2,node)} src={imgSrc} alt="" />                            
                            <div className={styles.bigYellowCircle}><span ref={(node)=>addToScrollItems(3,node)}>only ${products.at(pagination.currentPage)?.price}</span></div>
                        </div>
                    </div>
                </div>
            </section>
        </>
    );
}
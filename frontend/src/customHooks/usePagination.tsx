import  Indicator  from '@/components/indicator/Indicator';
import IPagination from '@/types/pagination/IPagination';
import { useState } from 'react';
import { JsxElement } from "typescript";

export default function usePagination({maxItemsOnPage,itemsLength}:{maxItemsOnPage:number,itemsLength:number}){
    const [pagination, setPagination] = useState<IPagination>({
        currentPage:0,
        maxProductsOnPage:maxItemsOnPage,
        maxPages:itemsLength/maxItemsOnPage,
    });
    function handleIndicatorClick(id:number){
        id--;
        setPagination({...pagination,currentPage:id+1});
    }
    const indicators = [];
    for (let index = 0; index < pagination.maxPages; index++) {
        let isActive = index===pagination.currentPage?true:false;
        indicators.push(     
            <Indicator key={index} isActive={isActive} onClick={()=>handleIndicatorClick(index)}/>
        );
    }
   return {pagination,indicators};
}
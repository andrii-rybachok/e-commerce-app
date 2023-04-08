import { useEffect, useState } from 'react';
import styles from './PopularProducts.module.css';
import IProductPreview from '@/types/products/product/IProductPreview';

import ProductPlate from '@/components/productPlate/ProductPlate';
import ICategory from '@/types/categories/category/ICategory';
import axios from 'axios';
import Indicator from '@/components/indicator/Indicator';
import { usePopProducts } from '../providers/PopularProductsProvider';
import IPagination from '@/types/pagination/IPagination';

export default function PopularProducts(){
    const [activeCategory, setActiveCategory] = useState<ICategory>({id:0,name:"Headphones"});
    let initialProducts =usePopProducts();
    const [products, setProducts] = useState<IProductPreview[]>([]);
    const [pagination, setPagination] = useState<IPagination>({
        currentPage:0,
        maxPages:3,
        maxProductsOnPage:8
    });
    useEffect(() => {
      setProducts(initialProducts);
      setPagination({
        ...pagination,
        maxPages:initialProducts.length/pagination.maxProductsOnPage,
      });
    }, [initialProducts])
    useEffect(()=>{
        const foo=async ()=>{
            const {data} = await axios.get<IProductPreview[]>("https://localhost:7100/api/shop/popular",{params:{categoryName:activeCategory.name}});
            setProducts(data);
            setPagination({
                ...pagination,
                maxPages:data.length/pagination.maxProductsOnPage,
                currentPage:0
              });           
        }
        foo();
    },[activeCategory])
    const popularCategories = [
        "Headphones",
        "Laptops",
    ]
    const productPlates =products.map((product)=>{
        return(
            <ProductPlate product={product} key={product.id}/>
        );
    })
    const categoryBtns=popularCategories.map((category,index)=>{{
        let style = index===activeCategory.id?styles.activeBtn: styles.categoryBtn;
        return (   
        <button key={index} className={style} onClick={()=>handleChangeCategory(index,category)}>
             {category}
         </button>
        );
       }
    })
    const indicators = [];
    for (let index = 0; index < pagination.maxPages; index++) {
        let isActive = index===pagination.currentPage?true:false;
        indicators.push(     
            <Indicator key={index} isActive={isActive} onClick={()=>handleIndicatorClick(index)}/>
        )
    }
    function handleChangeCategory(id:number,name:string){
        setActiveCategory({id:id,name:name});
        console.log(id);
    }
    function handleIndicatorClick(id:number){
        id--;
        setPagination({...pagination,currentPage:id+1});
    }
    console.log(pagination.currentPage*6,pagination.currentPage*6+6);
    if(initialProducts.length===0) return <h1>Loading...</h1>
    return(
        <section className={styles.popProducts}>
            <div className={styles.topContainer}>
            <h2 className={styles.title}>Popular products</h2>
                <div className={styles.btnsContainer}>
                    {categoryBtns}
                </div>
            </div>
            <div className={styles.productPlates}>
                {productPlates.slice(pagination.currentPage*pagination.maxProductsOnPage,pagination.currentPage*pagination.maxProductsOnPage+pagination.maxProductsOnPage)}
            </div>
            <div className={styles.indicators}>
                {indicators}
            </div>
        </section>
    );
}


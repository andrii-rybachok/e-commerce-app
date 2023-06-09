import MainOffer from "@/components/containers/home/mainOffer/MainOffer";
import ProductPlate from "@/components/productPlate/ProductPlate";
import IProductPreview from '@/types/products/product/IProductPreview';
import { MainOfferDataProvider } from "./providers/MainOfferProvider";
import PopularProducts from "./popularProducts/PopularProducts";
import defaultStyles from '@/Default.module.css';
import { PopularProductsDataProvider } from "./providers/PopularProductsProvider";
import Indicator from "@/components/indicator/Indicator";
import BigBanner from "./bigBanner/BigBanner";
import AdProducts from "./advertisingProducts/AdProducts";
import ProsPage from "./pros/ProsPage";
import Comments from "./fakeComments/Comments";
import Brands from "./brands/Brands";
import NewsPage from "./news/NewsPage";

export default function HomePage(){
    let test:IProductPreview={
        id:1,
        name:"Sony",
        previewImage:"https://localhost:7100/images/big/1_1.jpg",
        rating:5,
        secondImage:"null",
        price:300
    }
    return (
        <MainOfferDataProvider>
            <PopularProductsDataProvider>
                <div className={defaultStyles.topWrapper}>
                    <MainOffer/>
                    <PopularProducts/>
                    <BigBanner/>
                    <AdProducts/>
                    <ProsPage/>
                    <Comments/>
                    <Brands/>
                    <NewsPage/>
                </div>
            </PopularProductsDataProvider>
        </MainOfferDataProvider>
    );
}
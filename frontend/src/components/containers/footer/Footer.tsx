import styles from "./Footer.module.css"
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid ,regular, icon} from '@fortawesome/fontawesome-svg-core/import.macro'
import { Link } from "react-router-dom";
export default function Footer(){
    return (
      <footer className={styles.footer}>
        <div className={styles.footerWrapper}>
          <div className={styles.subBlock}>
            <h2 className={styles.subTitle}>Subscribe newsletter</h2>
            <button className={styles.subBtn}>
              Email adress <FontAwesomeIcon icon={solid("paper-plane")} />
            </button>
            <div className={styles.telBlock}>
              <FontAwesomeIcon icon={solid("headphones-simple")} />
              <span>Call us 24/7 : (+62) 0123 567 789</span>
            </div>
          </div>
          <div className={styles.bottomPart}>
            <div className={styles.leftPart}>
              <img src="images/logo_2.png" alt="" className={styles.logo}/>
              <p>64 st james boulevard hoswick , ze2 7zj</p>
              <div className={styles.brandIcons}>
                <Link to={"#"}>
                    <FontAwesomeIcon
                      icon={icon({ name: "google", style: "brands" })}
                    />
                </Link>
                <Link to={"#"}>
                    <FontAwesomeIcon
                      icon={icon({ name: "square-facebook", style: "brands" })}
                    />
                </Link>
                <Link to={"#"}>
                    <FontAwesomeIcon
                      icon={icon({ name: "viber", style: "brands" })}
                    />
                </Link>
              </div>
            </div>
            <div className={styles.list}>
              <h5>Find product</h5>
              <ul>
                <Link to={""}>
                    <li>Brownze arnold</li>
                </Link>
                <Link to={""}>
                    <li>Chronograph blue</li>
                </Link>
                <Link to={""}>
                    <li>Smart phones</li>
                </Link>
                <Link to={""}>
                    <li>Automatic watch</li>
                </Link>
                <Link to={""}>
                    <li>Hair straighteners</li>
                </Link>
              </ul>
            </div>
            <div className={styles.list}>
              <h5>Get help</h5>
              <ul>
                <Link to={""}>
                    <li>About us</li>
                </Link>
                <Link to={""}>
                    <li>Contact us</li>
                </Link>
                <Link to={""}>
                    <li>Return policy</li>
                </Link>
                <Link to={""}>
                    <li>Privacy policy</li>
                </Link>
                <Link to={""}>
                    <li>Payment policy</li>
                </Link>
              </ul>
            </div>
            <div className={styles.list}>
              <h5>About us</h5>
              <ul>
                <Link to={""}>
                    <li>News</li>
                </Link>
                <Link to={""}>
                    <li>Service</li>
                </Link>
                <Link to={""}>
                    <li>Our policy</li>
                </Link>
                <Link to={""}>
                    <li>Customer care</li>
                </Link>
                <Link to={""}>
                    <li>Faq’s</li>
                </Link>
              </ul>
            </div>
          </div>
        </div>
      </footer>
    );
}
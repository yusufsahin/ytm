// Generated by Selenium IDE
import org.junit.Test;
import org.junit.Before;
import org.junit.After;
import static org.junit.Assert.*;
import static org.hamcrest.CoreMatchers.is;
import static org.hamcrest.core.IsNot.not;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.remote.RemoteWebDriver;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.Dimension;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.Alert;
import org.openqa.selenium.Keys;
import java.util.*;
import java.net.MalformedURLException;
import java.net.URL;
public class OrderTestTest {
  private WebDriver driver;
  private Map<String, Object> vars;
  JavascriptExecutor js;
  @Before
  public void setUp() {
    driver = new ChromeDriver();
    js = (JavascriptExecutor) driver;
    vars = new HashMap<String, Object>();
  }
  @After
  public void tearDown() {
    driver.quit();
  }
  @Test
  public void orderTest() {
    // Test name: OrderTest
    // Step # | name | target | value
    // 1 | open | / | 
    driver.get("http://sportsstore.innovium.net/");
    // 2 | setWindowSize | 1936x1048 | 
    driver.manage().window().setSize(new Dimension(1936, 1048));
    // 3 | click | linkText=Home | 
    driver.findElement(By.linkText("Home")).click();
    // 4 | click | css=.card:nth-child(1) h4 | 
    driver.findElement(By.cssSelector(".card:nth-child(1) h4")).click();
    // 5 | click | css=.card:nth-child(1) > .bg-faded | 
    driver.findElement(By.cssSelector(".card:nth-child(1) > .bg-faded")).click();
    // 6 | waitForElementVisible | css=.card:nth-child(1) h4 | 30000
    {
      WebDriverWait wait = new WebDriverWait(driver, 30);
      wait.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector(".card:nth-child(1) h4")));
    }
    // 7 | click | xpath=//button[@type='submit'] | 
    driver.findElement(By.xpath("//button[@type=\'submit\']")).click();
    // 8 | click | css=h2 | 
    driver.findElement(By.cssSelector("h2")).click();
    // 9 | waitForElementVisible | css=h2 | 30000
    {
      WebDriverWait wait = new WebDriverWait(driver, 30);
      wait.until(ExpectedConditions.visibilityOfElementLocated(By.cssSelector("h2")));
    }
    // 10 | verifyText | css=h2 | Your cart
    assertThat(driver.findElement(By.cssSelector("h2")).getText(), is("Your cart"));
    // 11 | click | linkText=Checkout | 
    driver.findElement(By.linkText("Checkout")).click();
    // 12 | click | css=.col-9 | 
    driver.findElement(By.cssSelector(".col-9")).click();
    // 13 | waitForText | css=h2 | Check out now
    {
      WebDriverWait wait = new WebDriverWait(driver, 30);
      wait.until(ExpectedConditions.textToBe(By.cssSelector("h2"), "Check out now"));
    }
    // 14 | type | name=Name | John Doe
    driver.findElement(By.name("Name")).sendKeys("John Doe");
    // 15 | click | id=Line1 | 
    driver.findElement(By.id("Line1")).click();
    // 16 | type | id=Line1 | ABC Bulvard
    driver.findElement(By.id("Line1")).sendKeys("ABC Bulvard");
    // 17 | click | id=Line2 | 
    driver.findElement(By.id("Line2")).click();
    // 18 | type | id=Line2 | Main Street
    driver.findElement(By.id("Line2")).sendKeys("Main Street");
    // 19 | click | id=Line3 | 
    driver.findElement(By.id("Line3")).click();
    // 20 | type | id=Line3 | No 25
    driver.findElement(By.id("Line3")).sendKeys("No 25");
    // 21 | click | id=City | 
    driver.findElement(By.id("City")).click();
    // 22 | type | id=City | Austin
    driver.findElement(By.id("City")).sendKeys("Austin");
    // 23 | click | id=State | 
    driver.findElement(By.id("State")).click();
    // 24 | type | id=State | TX
    driver.findElement(By.id("State")).sendKeys("TX");
    // 25 | click | id=Zip | 
    driver.findElement(By.id("Zip")).click();
    // 26 | type | id=Zip | 75345
    driver.findElement(By.id("Zip")).sendKeys("75345");
    // 27 | click | id=Country | 
    driver.findElement(By.id("Country")).click();
    // 28 | type | id=Country | USA
    driver.findElement(By.id("Country")).sendKeys("USA");
    // 29 | click | css=.btn-primary | 
    driver.findElement(By.cssSelector(".btn-primary")).click();
    // 30 | click | css=h2 | 
    driver.findElement(By.cssSelector("h2")).click();
    // 31 | waitForText | css=h2 | Thanks!
    {
      WebDriverWait wait = new WebDriverWait(driver, 30);
      wait.until(ExpectedConditions.textToBe(By.cssSelector("h2"), "Thanks!"));
    }
    // 32 | verifyText | css=h2 | Thanks!
    assertThat(driver.findElement(By.cssSelector("h2")).getText(), is("Thanks!"));
    // 33 | click | linkText=Return to Store | 
    driver.findElement(By.linkText("Return to Store")).click();
  }
}

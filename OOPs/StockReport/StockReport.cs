using System;
/// <summary>
/// Stock report is the class ,it is the declaration of model class
/// </summary>
public class StockReport
{
    /// <summary>
    /// The stock name
    /// </summary>
    private string stockName;
    /// <summary>
    /// The number of share
    /// </summary>
    private int numberOfShare;
    /// <summary>
    /// The share price
    /// </summary>
    private long sharePrice;
    /// <summary>
    /// Gets or sets the name of the stock.
    /// </summary>
    /// <value>
    /// The name of the stock.
    /// </value>
    public string Name
    {
        get
        {
            return this.stockName;
        }
        set
        {
            this.stockName = value;
        }
    }
    /// <summary>
    /// Gets or sets the number of share.
    /// </summary>
    /// <value>
    /// The number of share.
    /// </value>
    public int NumberOfShare
    {
        get
        {
            return this.numberOfShare;
        }
        set
        {
            this.numberOfShare = value;
        }
    }
    /// <summary>
    /// Gets or sets the share price.
    /// </summary>
    /// <value>
    /// The share price.
    /// </value>
    public long SharePrice
    {
        get
        {
            return this.sharePrice;
        }
        set
        {
            this.sharePrice = value;
        }
    }
}

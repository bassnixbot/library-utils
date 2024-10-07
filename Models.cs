namespace UtilsLib;

public class Error
{
    public string errorCode { get; set; }
    public string errorMessage { get; set; }
    public string? errorStackTrace { get; set; }
}

public class ApiResponse<T>
{
    public ApiResponseType responseType { get; set; } = ApiResponseType.message;
    public bool success { get; set; }
    public T? result { get; set; }
    public Error? error { get; set; }
}

/// <summary>
/// The information about the client
/// </summary>
public class ClientInfo
{
    public string messageId {get ;set;}
    public string channel { get; set; }
    public string message { get; set; }
    public string? parentMessageId { get; set; }
    public UserInfo userInfo { get; set; }
}

/// <summary>
/// The information about the user who sent the message
/// </summary>
public class UserInfo
{

    /// <summary>
    /// The name of the user
    /// </summary>
    /// <value></value>
    public string userName { get; set; }

    /// <summary>
    /// The display name of the user
    /// </summary>
    /// <value></value>
    public string displayName { get; set; }

    /// <summary>
    /// The color the user choose to display in chat.
    /// Returns undefined if the user didn't choose a color.
    /// In this case, you should generate your own color for this user and stick to it at least for one runtime.
    /// </summary>
    /// <value></value>
    public string? color { get; set; }

    /// <summary>
    /// The ID of the user.
    /// </summary>
    /// <value></value>
    public string userId { get; set; }

    /// <summary>
    /// The type of the user
    /// Possible values are undefined, 'mod', 'global_mod', 'admin' and 'staff'. 
    /// </summary>
    /// <value></value>
    public string? userType { get; set; }

    /// <summary>
    /// Whether the user is the broadcaster
    /// </summary>
    /// <value></value>
    public bool isBroadcaster { get; set; } = false;

    /// <summary>
    /// Whether the user is subscribed to the channel.
    /// </summary>
    /// <value></value>
    public bool isSubscriber { get; set; } = false;

    /// <summary>
    /// Whether the user is a Founder of the channel.
    /// </summary>
    /// <value></value>
    public bool isFounder { get; set; } = false;

    /// <summary>
    /// Whether the user is a moderator of the channel.
    /// </summary>
    /// <value></value>
    public bool isMod { get; set; } = false;

    /// <summary>
    /// Whehter the user is a VIP in the channel.
    /// </summary>
    /// <value></value>
    public bool isVip { get; set; } = false;

    /// <summary>
    /// Whether the user is an artist of the channel.
    /// </summary>
    /// <value></value>
    public bool isArtist { get; set; } = false;
}

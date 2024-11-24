namespace UtilsLib;

public enum ApiResponseType {
    reply,
    message,
    message_array
}

public enum ChannelStatus {
    active,
    inactive,
    silent
}

public enum ReminderType {
    userreminder,
    timedreminder
}

public enum UserStatus {
    active,
    inactive
}

public enum AfkType
{
    afk,
    gn,
    lurk,
    custom
}

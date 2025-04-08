#include <windows.h>
#include <shellapi.h>

__declspec(dllexport) int __stdcall notify(const char* title, const char* message, const char* appid)
{
    char args[1024] = { 0 };
    sprintf_s(args, sizeof(args), "\"%s\" \"%s\" \"%s\"", title, message, appid);

    HINSTANCE result = ShellExecuteA(NULL, "open", "win_notifications.exe", args, NULL, SW_HIDE);
    return (int)(INT_PTR)result;
}

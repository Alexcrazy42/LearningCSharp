using MediatR;
using System.Globalization;

public class SomeEvent : INotification
{

    public string Message { get; }
    public SomeEvent(string message)
    {
        Message = message;
    }
}

public class Handler1 : INotificationHandler<SomeEvent>
{
    private readonly ILogger<Handler1> _logger;

    public Handler1(ILogger<Handler1> logger)
    {
        _logger = logger;
    }

    public void Handle(SomeEvent notification)
    {
        _logger.LogWarning($"Handled: {notification.Message}");
    }
}

public class Handler2 : INotificationHandler<SomeEvent>
{
    private readonly ILogger<Handler2> _logger;

    public Handler2(ILogger<Handler2> logger)
    {
        _logger = logger;
    }
    public void Handle(SomeEvent notification)
    {
        _logger.LogWarning($"Handled: {notification.Message}");
    }
}


public class HomeController : Controller
{

    private readonly IMediator _mediator;

    public HomeController(IMediator mediator)
    {
        this._mediator = mediator;
    }
    public async Task<IActionResult> Index()
    {
        await _mediator.Publish(new SomeEvent("Hello World"));
        return View();
    }
    // more code omitted
}
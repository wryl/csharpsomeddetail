//转换失败则response为null
IResponse response = message as IResponse;
//转换失败时报错
IResponse response = (IResponse)message;

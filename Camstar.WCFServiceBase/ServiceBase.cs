// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.ServiceBase
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.ComponentModel;

namespace Camstar.WCF.Service
{
  public abstract class ServiceBase
  {
    protected ResultStatus CallMethod(
      string name,
      UserProfile userProfile,
      DCObject cdo,
      Parameters parameters,
      Request request,
      Result result)
    {
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.CallServiceMethod(name, cdo, parameters, request, result, resultStatus);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected ResultStatus CallMethods(
      string name,
      UserProfile userProfile,
      Method[] methods,
      Request request,
      Result result)
    {
      try
      {
        ResultStatus resultStatus = new ResultStatus();
        ServerManager serverManager = new ServerManager(this.GetType().Name, userProfile);
        serverManager.CallServiceMethods(methods, request, result, resultStatus);
        serverManager.Close();
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected ResultStatus OnThrowException(Exception e)
    {
      if (e.InnerException != null)
        e = e.InnerException;
      ResultStatus resultStatus = new ResultStatus();
      resultStatus.IsSuccess = false;
      resultStatus.ExceptionData = new ExceptionDataType();
      if (e is Win32Exception)
        resultStatus.ExceptionData.Code = (e as Win32Exception).ErrorCode;
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Service;
      resultStatus.ExceptionData.Description = e.Message;
      resultStatus.ExceptionData.failureContext = e.StackTrace;
      resultStatus.ExceptionData.Source = e.Source;
      return resultStatus;
    }
  }
}

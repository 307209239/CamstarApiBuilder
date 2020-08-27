// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventLogsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventLogsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Parameters parameters,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventLogsMethod[] methods,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventLogs updateEventLogs,
      UpdateEventLogs_Request request,
      out UpdateEventLogs_Result result);
  }
}

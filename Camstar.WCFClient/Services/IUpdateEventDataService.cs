// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventDataService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Parameters parameters,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventDataMethod[] methods,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventData updateEventData,
      UpdateEventData_Request request,
      out UpdateEventData_Result result);
  }
}

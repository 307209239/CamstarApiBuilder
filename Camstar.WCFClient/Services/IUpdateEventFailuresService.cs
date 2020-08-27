// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventFailuresService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventFailuresService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventFailuresMethod[] methods,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result);
  }
}

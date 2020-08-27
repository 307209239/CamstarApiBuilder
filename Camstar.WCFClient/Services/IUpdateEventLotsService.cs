// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventLotsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventLotsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventLotsMethod[] methods,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result);
  }
}

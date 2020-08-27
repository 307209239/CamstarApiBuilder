// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICreateProductionEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICreateProductionEventService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus Hold(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus PrintLabels(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CreateProductionEventMethod[] methods,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result);
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEmptyCarrierService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEmptyCarrierService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_LoadESigDetails_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EmptyCarrierMethod[] methods,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result);
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeQtyService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeQtyService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus GetChangeQtyDetails(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_GetChangeQtyDetails_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_LoadESigDetails_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Parameters parameters,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeQtyMethod[] methods,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeQty changeQty,
      ChangeQty_Request request,
      out ChangeQty_Result result);
  }
}

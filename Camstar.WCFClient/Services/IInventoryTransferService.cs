// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IInventoryTransferService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IInventoryTransferService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_LoadESigDetails_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Parameters parameters,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      InventoryTransferMethod[] methods,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      InventoryTransfer inventoryTransfer,
      InventoryTransfer_Request request,
      out InventoryTransfer_Result result);
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IShipmentDestinationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IShipmentDestinationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_LoadESigDetails_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ShipmentDestinationMaintMethod[] methods,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result);
  }
}

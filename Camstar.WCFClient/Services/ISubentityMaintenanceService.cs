// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISubentityMaintenanceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISubentityMaintenanceService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_LoadESigDetails_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Parameters parameters,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SubentityMaintenanceMethod[] methods,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SubentityMaintenance subentityMaintenance,
      SubentityMaintenance_Request request,
      out SubentityMaintenance_Result result);
  }
}

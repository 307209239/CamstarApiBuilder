// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetMaintenanceStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetMaintenanceStatusesService
  {
    [OperationContract]
    ResultStatus FilterDateReq(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_FilterDateReq_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus FilterRecurringDateReq(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_FilterRecurringDateReq_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus FilterThruputReq(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_FilterThruputReq_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus GetMaintenanceStatuses(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetMaintenanceStatusesMethod[] methods,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result);
  }
}

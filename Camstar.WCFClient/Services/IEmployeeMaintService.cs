// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEmployeeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEmployeeMaintService
  {
    [OperationContract]
    ResultStatus AddRoles(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus DeleteRoles(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_LoadESigDetails_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EmployeeMaintMethod[] methods,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result);
  }
}

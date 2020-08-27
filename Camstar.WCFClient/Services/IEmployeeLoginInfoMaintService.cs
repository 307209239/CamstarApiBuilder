// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IEmployeeLoginInfoMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IEmployeeLoginInfoMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_LoadESigDetails_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      EmployeeLoginInfoMaintMethod[] methods,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result);
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EmployeeRoleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EmployeeRoleMaintService : SubentityMaintenanceBase
  {
    public EmployeeRoleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEmployeeRoleMaintService), userProfile);
    }

    public ResultStatus Delete(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).Delete(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus Delete(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.Delete(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus Delete(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.Delete(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).Freeze(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus Freeze(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.Freeze(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus Freeze(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.Freeze(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.GetWIPMsgs(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.GetWIPMsgs(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).Load(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus Load(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.Load(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus Load(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.Load(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_LoadESigDetails_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).LoadESigDetails(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.LoadESigDetails, (EmployeeRoleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EmployeeRoleMaint) null, (EmployeeRoleMaint_LoadESigDetails_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.LoadESigDetails(employeeRoleMaint, (EmployeeRoleMaint_LoadESigDetails_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.LoadESigDetails(employeeRoleMaint, (EmployeeRoleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).New(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus New(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.New(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus New(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.New(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).NewCopy(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus NewCopy(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.NewCopy(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus NewCopy(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.NewCopy(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).SaveAs(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus SaveAs(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.SaveAs(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus SaveAs(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.SaveAs(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Parameters parameters,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).UnFreeze(this._UserProfile, employeeRoleMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(employeeRoleMaint, EmployeeRoleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) employeeRoleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EmployeeRoleMaint) null, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus UnFreeze(EmployeeRoleMaint employeeRoleMaint)
    {
      return this.UnFreeze(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EmployeeRoleMaint employeeRoleMaint,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.UnFreeze(employeeRoleMaint, (EmployeeRoleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_LoadESigDetails_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.New((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.Load((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject employeeRoleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EmployeeRoleMaint) employeeRoleMaint, (EmployeeRoleMaint_Parameters) parameters, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      try
      {
        EmployeeRoleMaintMethod[] methods = new EmployeeRoleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEmployeeRoleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmployeeRoleMaint cdo,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      try
      {
        return ((IEmployeeRoleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EmployeeRoleMaint) cdo, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.GetEnvironment((EmployeeRoleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EmployeeRoleMaint cdo,
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      result = (EmployeeRoleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeRoleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EmployeeRoleMaintMethod(cdo, EmployeeRoleMaintMethods.ExecuteTransaction, (EmployeeRoleMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeRoleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EmployeeRoleMaint) cdo, (EmployeeRoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EmployeeRoleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EmployeeRoleMaint_Request) null, out EmployeeRoleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EmployeeRoleMaint_Request request,
      out EmployeeRoleMaint_Result result)
    {
      return this.ExecuteTransaction((EmployeeRoleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EmployeeRoleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EmployeeRoleMaintMethod(cdo, EmployeeRoleMaintMethods.AddDataTransaction, (EmployeeRoleMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((EmployeeRoleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

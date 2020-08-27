// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EmployeeLoginInfoMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EmployeeLoginInfoMaintService : SubentityMaintenanceBase
  {
    public EmployeeLoginInfoMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEmployeeLoginInfoMaintService), userProfile);
    }

    public ResultStatus Delete(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).Delete(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus Delete(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.Delete(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus Delete(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.Delete(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).Freeze(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus Freeze(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.Freeze(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus Freeze(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.Freeze(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).GetWIPMsgs(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.GetWIPMsgs(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.GetWIPMsgs(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).Load(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus Load(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.Load(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus Load(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.Load(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_LoadESigDetails_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).LoadESigDetails(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.LoadESigDetails, (EmployeeLoginInfoMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_LoadESigDetails_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.LoadESigDetails(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_LoadESigDetails_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.LoadESigDetails(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).New(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus New(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.New(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus New(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.New(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).NewCopy(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus NewCopy(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.NewCopy(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus NewCopy(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.NewCopy(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).SaveAs(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus SaveAs(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.SaveAs(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus SaveAs(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.SaveAs(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Parameters parameters,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).UnFreeze(this._UserProfile, employeeLoginInfoMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(employeeLoginInfoMaint, EmployeeLoginInfoMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) employeeLoginInfoMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EmployeeLoginInfoMaint) null, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus UnFreeze(EmployeeLoginInfoMaint employeeLoginInfoMaint)
    {
      return this.UnFreeze(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EmployeeLoginInfoMaint employeeLoginInfoMaint,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.UnFreeze(employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_LoadESigDetails_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.New((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.Load((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject employeeLoginInfoMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EmployeeLoginInfoMaint) employeeLoginInfoMaint, (EmployeeLoginInfoMaint_Parameters) parameters, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      try
      {
        EmployeeLoginInfoMaintMethod[] methods = new EmployeeLoginInfoMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEmployeeLoginInfoMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmployeeLoginInfoMaint cdo,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      try
      {
        return ((IEmployeeLoginInfoMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EmployeeLoginInfoMaint) cdo, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.GetEnvironment((EmployeeLoginInfoMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EmployeeLoginInfoMaint cdo,
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      result = (EmployeeLoginInfoMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeLoginInfoMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(cdo, EmployeeLoginInfoMaintMethods.ExecuteTransaction, (EmployeeLoginInfoMaint_Parameters) null));
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
        EmployeeLoginInfoMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EmployeeLoginInfoMaint) cdo, (EmployeeLoginInfoMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EmployeeLoginInfoMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EmployeeLoginInfoMaint_Request) null, out EmployeeLoginInfoMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EmployeeLoginInfoMaint_Request request,
      out EmployeeLoginInfoMaint_Result result)
    {
      return this.ExecuteTransaction((EmployeeLoginInfoMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EmployeeLoginInfoMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EmployeeLoginInfoMaintMethod(cdo, EmployeeLoginInfoMaintMethods.AddDataTransaction, (EmployeeLoginInfoMaint_Parameters) null));
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
        return this.AddDataTransaction((EmployeeLoginInfoMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

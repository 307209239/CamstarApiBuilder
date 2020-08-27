// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EmployeeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EmployeeMaintService : NamedDataObjectMaintBase
  {
    public EmployeeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEmployeeMaintService), userProfile);
    }

    public ResultStatus AddRoles(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (AddRoles), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).AddRoles(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.AddRoles, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddRoles), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddRoles()
    {
      return this.AddRoles((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus AddRoles(EmployeeMaint employeeMaint)
    {
      return this.AddRoles(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus AddRoles(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.AddRoles(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).Delete(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus Delete(EmployeeMaint employeeMaint)
    {
      return this.Delete(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus Delete(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.Delete(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteRoles(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteRoles), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).DeleteRoles(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.DeleteRoles, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteRoles), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteRoles()
    {
      return this.DeleteRoles((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus DeleteRoles(EmployeeMaint employeeMaint)
    {
      return this.DeleteRoles(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus DeleteRoles(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.DeleteRoles(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).Freeze(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus Freeze(EmployeeMaint employeeMaint)
    {
      return this.Freeze(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus Freeze(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.Freeze(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EmployeeMaint employeeMaint)
    {
      return this.GetWIPMsgs(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.GetWIPMsgs(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).Load(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus Load(EmployeeMaint employeeMaint)
    {
      return this.Load(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus Load(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.Load(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EmployeeMaint employeeMaint,
      EmployeeMaint_LoadESigDetails_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).LoadESigDetails(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.LoadESigDetails, (EmployeeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EmployeeMaint) null, (EmployeeMaint_LoadESigDetails_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EmployeeMaint employeeMaint)
    {
      return this.LoadESigDetails(employeeMaint, (EmployeeMaint_LoadESigDetails_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.LoadESigDetails(employeeMaint, (EmployeeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).New(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus New(EmployeeMaint employeeMaint)
    {
      return this.New(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus New(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.New(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).NewCopy(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus NewCopy(EmployeeMaint employeeMaint)
    {
      return this.NewCopy(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus NewCopy(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.NewCopy(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).SaveAs(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus SaveAs(EmployeeMaint employeeMaint)
    {
      return this.SaveAs(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus SaveAs(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.SaveAs(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Parameters parameters,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) employeeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).UnFreeze(this._UserProfile, employeeMaint, parameters, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(employeeMaint, EmployeeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) employeeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EmployeeMaint) null, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus UnFreeze(EmployeeMaint employeeMaint)
    {
      return this.UnFreeze(employeeMaint, (EmployeeMaint_Parameters) null, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EmployeeMaint employeeMaint,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.UnFreeze(employeeMaint, (EmployeeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EmployeeMaint) employeeMaint, (EmployeeMaint_LoadESigDetails_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.New((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.Load((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject employeeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmployeeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EmployeeMaint) employeeMaint, (EmployeeMaint_Parameters) parameters, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      try
      {
        EmployeeMaintMethod[] methods = new EmployeeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEmployeeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmployeeMaint cdo,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      try
      {
        return ((IEmployeeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EmployeeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EmployeeMaint) cdo, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.GetEnvironment((EmployeeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EmployeeMaint cdo,
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      result = (EmployeeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmployeeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EmployeeMaintMethod(cdo, EmployeeMaintMethods.ExecuteTransaction, (EmployeeMaint_Parameters) null));
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
        EmployeeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EmployeeMaint) cdo, (EmployeeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EmployeeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EmployeeMaint_Request) null, out EmployeeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EmployeeMaint_Request request,
      out EmployeeMaint_Result result)
    {
      return this.ExecuteTransaction((EmployeeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EmployeeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EmployeeMaintMethod(cdo, EmployeeMaintMethods.AddDataTransaction, (EmployeeMaint_Parameters) null));
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
        return this.AddDataTransaction((EmployeeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

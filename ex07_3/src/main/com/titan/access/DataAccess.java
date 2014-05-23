package com.titan.access;

import javax.ejb.Remote;
import java.util.List;

@Remote
public interface DataAccess
{
   String initializeDatabase();
   public List fetchReservations();
   public List fetchReservationsWithRelationships();
}

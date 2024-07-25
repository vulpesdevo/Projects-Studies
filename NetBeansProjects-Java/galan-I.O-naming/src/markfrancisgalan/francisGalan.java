package markfrancisgalan;

import javax.swing.JOptionPane;

public class francisGalan extends javax.swing.JFrame {

    public francisGalan() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        fnameGalan = new javax.swing.JLabel();
        mnameGalan = new javax.swing.JLabel();
        lnameGalan = new javax.swing.JLabel();
        FnameGalan = new javax.swing.JTextField();
        MnameGalan = new javax.swing.JTextField();
        LnameGalan = new javax.swing.JTextField();
        enterGalan = new javax.swing.JButton();
        clearGalan = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));

        fnameGalan.setFont(new java.awt.Font("Verdana", 1, 14)); // NOI18N
        fnameGalan.setText("First Name:");

        mnameGalan.setFont(new java.awt.Font("Verdana", 1, 14)); // NOI18N
        mnameGalan.setText("Middle Name:");

        lnameGalan.setFont(new java.awt.Font("Verdana", 1, 14)); // NOI18N
        lnameGalan.setText("Last Name:");

        FnameGalan.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        FnameGalan.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 0, 0), 1, true));
        FnameGalan.setCursor(new java.awt.Cursor(java.awt.Cursor.TEXT_CURSOR));

        MnameGalan.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        MnameGalan.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 0, 0), 1, true));

        LnameGalan.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        LnameGalan.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 0, 0), 1, true));

        enterGalan.setBackground(new java.awt.Color(102, 255, 102));
        enterGalan.setFont(new java.awt.Font("Trebuchet MS", 0, 14)); // NOI18N
        enterGalan.setText("Enter");
        enterGalan.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED, new java.awt.Color(204, 204, 204), new java.awt.Color(204, 204, 204), new java.awt.Color(51, 51, 51), new java.awt.Color(102, 102, 102)));
        enterGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                enterGalanActionPerformed(evt);
            }
        });

        clearGalan.setBackground(new java.awt.Color(255, 102, 102));
        clearGalan.setFont(new java.awt.Font("Trebuchet MS", 0, 14)); // NOI18N
        clearGalan.setText("Clear");
        clearGalan.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED, new java.awt.Color(204, 204, 204), new java.awt.Color(204, 204, 204), new java.awt.Color(51, 51, 51), new java.awt.Color(102, 102, 102)));
        clearGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                clearGalanActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(31, 31, 31)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(fnameGalan)
                            .addComponent(mnameGalan)
                            .addComponent(lnameGalan))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(FnameGalan)
                            .addComponent(MnameGalan)
                            .addComponent(LnameGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 240, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(31, 31, 31)
                        .addComponent(enterGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(27, 27, 27)
                        .addComponent(clearGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(57, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(70, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(fnameGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(FnameGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(MnameGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(mnameGalan))
                .addGap(26, 26, 26)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lnameGalan)
                    .addComponent(LnameGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(51, 51, 51)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(enterGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(clearGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(60, 60, 60))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void enterGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_enterGalanActionPerformed
        String firstnameGalan = FnameGalan.getText();
        String middlenameGalan = MnameGalan.getText();
        String lastnameGalan = LnameGalan.getText();
        JOptionPane.showMessageDialog(null, lastnameGalan + ", " + firstnameGalan
                + " " + middlenameGalan);
    }//GEN-LAST:event_enterGalanActionPerformed

    private void clearGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_clearGalanActionPerformed
        FnameGalan.setText("");
        MnameGalan.setText("");
        LnameGalan.setText("");
    }//GEN-LAST:event_clearGalanActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new francisGalan().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField FnameGalan;
    private javax.swing.JTextField LnameGalan;
    private javax.swing.JTextField MnameGalan;
    private javax.swing.JButton clearGalan;
    private javax.swing.JButton enterGalan;
    private javax.swing.JLabel fnameGalan;
    private javax.swing.JLabel lnameGalan;
    private javax.swing.JLabel mnameGalan;
    // End of variables declaration//GEN-END:variables
}
